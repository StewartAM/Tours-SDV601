using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Stewarts_Travel
{
    [Serializable]
    public class ClsCompany
    {
        private static Dictionary<string, ClsTour> _TourList = new Dictionary<string, ClsTour>();

        public static string Savefile;

        public static Dictionary<string, ClsTour> TourList
        {
            get{return _TourList;}
            set{_TourList = value;}
        }

        //save
        public static void Save()
        {
            Savefile = "C:\\Users\\Stewart\\Documents\\2018 First Semester\\SDV601\\Projects\\Stewarts Travel\\tours.dat";
            using (FileStream lcFileStream = new FileStream(Savefile, FileMode.Create))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                lcFormatter.Serialize(lcFileStream, _TourList);
            }
        }

        //retrieve on form main load
        public static void Retrieve()
        {
            Savefile = "C:\\Users\\Stewart\\Documents\\2018 First Semester\\SDV601\\Projects\\Stewarts Travel\\tours.dat";
            using (FileStream lcFileStream = new FileStream(Savefile, FileMode.Open))
            {
                BinaryFormatter lcFormatter = new BinaryFormatter();
                _TourList = (Dictionary<string, ClsTour>)
                                lcFormatter.Deserialize(lcFileStream);
            }
        }
    }
}
