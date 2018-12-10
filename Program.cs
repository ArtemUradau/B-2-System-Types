using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practice.B2_P1_1_TypeConvert();
            string name = "Olga";
            string hasPhoto = "True";
            string flatNumber = "34";

            char sex = 'М';
            char place = '3';
            char hasFingerPrints = '0';

            bool hasFree2Pages = false;

            double visaPrice = 60;
            double photoPrice = 7.5;

            int birthYear = 2000;

            //1. CHAR CONVERSION 
            //1.1 CHAR to STRING

            //string charToStringImplicit = sex;                        //IMPLICIT: NOT COMPILING
            //string chartToStringExplicit = (string)sex;               //EXPLICIT: NOT COMPILING
            string charToStringUsingConverter = Convert.ToString(sex);  //CONVERT: "M"

            //1.2 CHAR to BOOL   
            //bool charToBoolImplicit = place;                          //IMPLICIT: NOT COMPILING
            //bool charToBoolExplicit = (bool)place;                    //EXPLICIT: NOT COMPILING
            //bool charToBoolUsingConverter = Convert.ToBoolean(place); //CONVERT: NOT COMPILING

            //1.3 CHAR to DECIMAL
            decimal charToDecimalImplicit = hasFingerPrints;                            //IMPLICIT: 48
            decimal charToDecimalExplicit = (decimal)hasFingerPrints;                   //EXPLICIT: 48
            //decimal charToDecimalUsingConverter = Convert.ToDecimal(hasFingerPrints); //CONVERT: NOT COMPILING

            //1.4 CHAR to INT
            int charToIntImplicit = sex;                        //Implicit: 1052
            int charToIntExplicit = (int)sex;                   //EXPLICIT: 1052
            int charToIntUsingConverter = Convert.ToInt32(sex); //CONVERT: 1052

            //2. STRING CONVERSION
            //2.1 STRING to CHAR
            //char stringToCharImplicit = name;                       //IMPLICIT: NOT COMPILING
            //char stringToCharExplicit = (char)name;                 //EXPLICIT: NOT COMPILING
            //char stringToCharUsingConverter = Convert.ToChar(name); //CONVERT: NOT COMPILING

            //2.2 STRING to BOOL
            //bool stringToBoolImplicit = hasPhoto;                        //IMPLICIT: NOT COMPILING
            //bool stringToBoolExplicit = (bool)hasPhoto;                  //EXPLICIT: NOT COMPILING
            bool stringToBoolUsingConverter = Convert.ToBoolean(hasPhoto); //CONVERT: TRUE

            //2.3 STRING to DECIMAL
            //decimal stringToDecimalImplicit = flatNumber;                        //IMPLICIT: NOT COMPILING
            //decimal stringToDecimalExplicit = (decimal)flatNumber;               //EXPLICIT: NOT COMPILING
            decimal stringToDecimalUsingConverter = Convert.ToDecimal(flatNumber); //CONVERT: 34

            //2.4 STRING to INT
            //int stringToIntImplicit = name;                        //IMPLICIT: NOT COMPILING
            //int stringToIntExplicit = (int)name;                   //EXPLICIT: NOT COMPILING
            //int stringToIntUsingConverter = Convert.ToInt32(name); //CONVERT: NOT COMPILING

            //3. BOOL CONVERSION
            //3.1 BOOL to CHAR
            //char boolToCharImplicit = hasFree2Pages;                       //IMPLICIT: NOT COMPILING
            //char boolToCharExplicit = (char)hasFree2Pages;                 //EXPLICIT: NOT COMPILING
            //char boolToCharUsingConverter = Convert.ToChar(hasFree2Pages); //CONVERT: NOT COMPILING

            //3.2 BOOL to STRING
            //string boolToStringImplicit = hasFree2Pages;                       //IMPLICIT: NOT COMPILING
            //string boolToStringExplicit = (string)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            string boolToStringUsingConverter = Convert.ToString(hasFree2Pages); //CONVERT: FALSE

            //3.3 BOOL to DECIMAL
            //decimal boolToDecimalImplicit = hasFree2Pages;                        //IMPLICIT: NOT COMPILING
            //decimal boolToDecimalExplicit = (decimal)hasFree2Pages;               //EXPLICIT: NOT COMPILING
            decimal boolToDecimalUsingConverter = Convert.ToDecimal(hasFree2Pages); //CONVERT: 0

            //3.4 BOOL to INT
            //int boolToIntImplicit = hasFree2Pages;                      //IMPLICIT: NOT COMPILING
            //int boolToIntExplicit = (int)hasFree2Pages;                 //EXPLICIT: NOT COMPILING
            int boolToIntUsingConverter = Convert.ToInt32(hasFree2Pages); //CONVERT: 0

            //4. DECIMAL CONVERSION
            //4.1 DECIMAL to CHAR
            //char decimalToCharImplicit = visaPrice;                       //IMPLICIT: NOT COMPILING
            //char decimalToCharExplicit = (char)visaPrice;                 //EXPLICIT: NOT COMPILING
            //char decimalToCharUsingConverter = Convert.ToChar(visaPrice); //CONVERT: NOT COMPILING

            //4.2 DECIMAL to BOOL
            //bool decimalToBoolImplicit = photoPrice;                        //IMPLICIT: NOT COMPILING
            //bool decimalToBoolExplicit = (bool)photoPrice;                  //EXPLICIT: NOT COMPILING
            bool decimalToBoolUsingConverter = Convert.ToBoolean(photoPrice); //CONVERT: TRUE

            //4.3 DECIMAL to STRING
            //string decimalToStringImplicit = visaPrice;                       //IMPLICIT: NOT COMPILING
            //string decimalToStringExplicit = (string)visaPrice;               //EXPLICIT: NOT COMPILING
            string decimalToStringUsingConverter = Convert.ToString(visaPrice); //CONVERT: 60

            //4.4 DECIMAL to INT
            //int decimalToIntImplicit = photoPrice;                       //IMPLICIT: NOT COMPILING
            int decimalToIntExplicit = (int)photoPrice;                    //EXPLICIT: 7
            int decimalToIntUsingConverter = Convert.ToUInt16(photoPrice); //CONVERT: 8

            //5. INT CONVERSION         
            //5.1 INT to CHAR
            //char intToCharImplicit = birthYear;                     //IMPLICIT: NOT COMPILING
            char intToCharExplicit = (char)birthYear;                 //EXPLICIT: ?
            char intToCharUsingConverter = Convert.ToChar(birthYear); //CONVERT: ?

            //5.2 INT to BOOL
            //bool intToBoolImplicit = birthYear;                        //IMPLICIT: NOT COMPILING
            //bool intToBoolExplicit = (bool)birthYear;                  //EXPLICIT: NOT COMPILING
            bool intToBoolUsingConverter = Convert.ToBoolean(birthYear); //CONVERT: TRUE

            //5.3 INT to DECIMAL
            decimal intToDecimalImplicit = birthYear;                          //IMPLICIT: 2000
            decimal intToDecimalExplicit = (decimal)birthYear;                 //EXPLICIT: 2000
            decimal intToDecimalUsingConverter = Convert.ToDecimal(birthYear); //CONVERT: 2000

            //5.4 INT to STRING
            //string intToStringImplicit = birthYear;                       //IMPLICIT: NOT COMPILING
            //string intToStringExplicit = (string)birthYear;               //EXPLICIT: NOT COMPILING
            string intToStringUsingConverter = Convert.ToString(birthYear); //CONVERT: 2000
            Console.ReadLine();
        }
    }
}
