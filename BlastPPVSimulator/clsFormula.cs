using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
namespace WindowsFormsApplication1
{
    class clsFormula
    {
        //This class defines each PPV formula used in blast simulation. Each of the formula will produce Peak Particle Velocity (mm/s)
        // as the output based on three inputs from user and some predefined constants 

        //1.Holmberg-Persson 

            /*        V = k (Q^a/R^b )	

            Where;
            V= Peak particle velocity (mm/s)
            k = rock transmission factor 
            a, b = empirical site constants
	            R = distance from blast to measuring point (m)
	            Q = Maximum Charge per delay (kg)


            Q = qL

            Where;		Q = charge weight
		            L = length of charge (m)
		            q = charge concentration per unit length (kg/m)
 
            Therefore;

            V	= k(Q^a)/( R^b)
	            = k 〖(qL)〗^a/(〖R)〗^b
            */
      
        public static double Holmberg_Persson(double Distance, double ChargeLength, double ChargeConcentrationPerUnitLength)
        {
            double V, k, R, L, q, Q,a, b;
            k = getk();
            a = geta();
            b = getb();
            R = Distance; 
            L = ChargeLength;
            q = ChargeConcentrationPerUnitLength;
            Q = getQ(L, q);
            V = k * (Power(Q,a) / Power(R,b));
            return V;
        }
        public static double Power(double firstNumber, double secondNumber)
        {
            double result = Math.Pow(firstNumber, secondNumber);
            return result;
        }
        //--------------------------------------------------------------


        //2.USBM (Unitech States Bureau of Mines) 

        /*
             V = k(R/√Q)^(-b)
            Where;
            V= Peak particle velocity (mm/s)
            k = rock transmission factor
	            b = empirical constants
	            R = distance from blast to measuring point (m)
	            Q = Maximum Charge per delay (kg)

            Q = qL

            Where;		Q = charge weight
		            L = length of charge (m)
		            q = charge concentration per unit length (kg/m)
 
            Therefore;

	            V = k(R/√Q)^(-b)
            V = k(R/√qL)^(-b)

         */
        public static double USBM(double Distance, double ChargeLength, double ChargeConcentrationPerUnitLength)
        {
            double V, k, R, L, q, Q,b;
            k = getk();
            b = getb();
            R = Distance;
            L = ChargeLength;
            q = ChargeConcentrationPerUnitLength;
            Q = getQ(L, q);
            V = k * Power(R / Math.Sqrt(Q), -b);
            return V;
        }
        //------------------------------------------

        //3.	Langefors – Kihlstrom
        /*
            V = k(Q/R^(3/2) )^(-b)
            Where;
            V = Peak particle velocity (mm/s)
            k = rock transmission factor
	            b = empirical constant
	            R = distance from blast to measuring point (m)
	            Q = Maximum Charge per delay (kg)

            Q = qL

            Where;		Q = charge weight
		            L = length of charge (m)
		            q = charge concentration per unit length (kg/m)
 
            Therefore;

	            V = k(Q/R^(3/2) )^(-b)
            V = k((q×L)/R^(2/3) )^(-b)

         */
        public static double Langefors_Kihlstrom(double Distance, double ChargeLength, double ChargeConcentrationPerUnitLength)
        {
            double V, k, R, L, q, Q,b;
            k = getk();
            b = getb();
            R = Distance; 
            L = ChargeLength;
            q = ChargeConcentrationPerUnitLength;
            Q = getQ(L, q);
            V = k * Power((Q/Math.Sqrt(Math.Pow(R,3))),-b);
            return V;
        }
        //--------------------------------------------------

        //4.	Ambraseys – Hendron 
        /*
            V = k(R/(Q1/3))-b

            Where;
            V = Peak particle velocity (mm/s)
            k = rock transmission factor
	            b = empirical constant
	            R = distance from blast to measuring point (m)
	            Q = Maximum Charge per delay (kg)

            Q = qL

            Where;		Q = charge weight
		            L = length of charge (m)
		            q = charge concentration per unit length (kg/m)
 
            Therefore;
            V = k(R/(Q1/3))-b
            V = k(R/(qL1/3))-b
         */
        public static double Ambraseys_Hendron(double Distance, double ChargeLength, double ChargeConcentrationPerUnitLength)
        {
            double V, k, R, L, q, Q,b;
            k = getk();
            b = getb();
            R = Distance; 
            L = ChargeLength;
            q = ChargeConcentrationPerUnitLength;
            Q = getQ(L, q);
            V = k * Power((R /Math.Pow(Q, (1.0 / 3))), -b);
           return V;
        }
        //-------------------------------------------------------

        //Define Helper functions here
        public static double getk()
        {
            string s = "SELECT RockTransFactor FROM Constants";
            return double.Parse(ExecuteQuery(s));
        }
        public static double getb()
        {
            string s = "SELECT EmphiricalConstantb FROM Constants";
            return double.Parse(ExecuteQuery(s));
        }
        public static double geta()
        {
            string s = "SELECT EmphiricalConstanta FROM Constants";
            return double.Parse(ExecuteQuery(s));
        }

        public static double getQ(double LengthOfCharge,double ChargeConcentrationPerUnitLength)
        {
            return LengthOfCharge * ChargeConcentrationPerUnitLength;
        }


        //Function to retrieve constants for  database
        private static string ExecuteQuery(string s)
        {
            string constant = "0";
            using (SQLiteConnection c = new SQLiteConnection(dbConnection.sConnectingString))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(s, c))
                {
                    cmd.Connection.Open();
                    using (SQLiteDataReader d = cmd.ExecuteReader())
                    {
                        while (d.Read())
                        {
                            constant = d.GetValue(0).ToString();
                        }
                    }
                }
            }
            return constant;
        }
    }
}
