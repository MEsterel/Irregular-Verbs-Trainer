using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IVT.Objects;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace IVT.Tools
{
    public static class HistoryManager
    {
        public static List<TrainingHistory> GetTrainingHistoryList()
        {
            return FromByteArray<List<TrainingHistory>>(DecodeToByteArray(Properties.Settings.Default.historical));
        }

        public static void AddTrainingHistory(TrainingHistory th)
        {
            List<TrainingHistory> thList = FromByteArray<List<TrainingHistory>>(DecodeToByteArray(Properties.Settings.Default.historical));
            thList.Insert(0, th);
            Properties.Settings.Default.historical = EncodeToBase64String(ToByteArray(thList));
            Properties.Settings.Default.Save();
        }

        public static void ClearTrainingHistoryList()
        {
            List<TrainingHistory> thList = new List<TrainingHistory>();
            Properties.Settings.Default.historical = EncodeToBase64String(ToByteArray(thList));
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Remove a TrainingHistory of the list with its date.
        /// </summary>
        /// <param name="date"></param>
        public static void RemoveTrainingHistory(DateTime date)
        {
            List<TrainingHistory> thList = FromByteArray<List<TrainingHistory>>(DecodeToByteArray(Properties.Settings.Default.historical));
            thList.Remove(thList.FirstOrDefault(x => x.Date == date));
            Properties.Settings.Default.historical = EncodeToBase64String(ToByteArray(thList));
            Properties.Settings.Default.Save();
        }

        public static TrainingHistory GetTrainingHistory(DateTime date)
        {
            List<TrainingHistory> thList = FromByteArray<List<TrainingHistory>>(DecodeToByteArray(Properties.Settings.Default.historical));
            return thList.FirstOrDefault(x => x.Date == date);
        }

        private static byte[] ToByteArray<T>(T obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        private static T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream(data))
            {
                object obj = bf.Deserialize(ms);
                return (T)obj;
            }
        }

        private static string EncodeToBase64String(byte[] obj)
        {
            return Convert.ToBase64String(obj);
        }

        private static byte[] DecodeToByteArray(string s)
        {
            return Convert.FromBase64String(s);
        }
    }
}
