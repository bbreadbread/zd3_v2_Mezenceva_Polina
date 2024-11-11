using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_v2_Mezenceva_Polina
{
    class Roadworks
    {
        CoefOfSafety safety;
        public static List<CoefOfSafety> roadList = new List<CoefOfSafety>();
        public double width { get; set; }
        public double lenght { get; set; }
        public double roadMass { get; set; }
        public string locate { get; set; } //свое поле 1
        public string type { get; set; } // свое поле 2

        //конструктор по умолчанию
        public Roadworks()
        { }
        //конструктор
        public Roadworks(double width, double lenght, double roadMass, string locate, string type)
        {
            this.width = width;
            this.lenght = lenght;
            this.roadMass = roadMass;
            this.locate = locate;
            this.type = type;
        }
        //вычисляем Q
        public double Q()
        {
            return width * lenght * roadMass / 1000;
        }
        public string GetInfo(double index)//вывод информации
        {
            safety = new CoefOfSafety(width, lenght, roadMass, type, type, index, "", 0, "");
            return $"\nШирина дороги: {width}," +
                    $"\nДлина: {lenght}," +
                    $"\nМасса дорожного покрытия на 1 кв.м.: {roadMass}" +
                    $"\nМестоположение:{locate}," +
                    $"\nТип дорожного покрытия:{type};" +
                    $"\nQ = {Q()}," +
                    $"\nQp = {safety.Qp()}.";
        }

        public string GetInfo()//вывод информации для метода поиска по типу покрытия
        {
            return $"\nШирина дороги: {width}," +
                        $"\nДлина: {lenght}," +
                        $"\nМасса дорожного покрытия на 1 кв.м.: {roadMass}" +
                        $"\nМестоположение:{locate}," +
                        $"\nТип дорожного покрытия:{type}." +
                        "\n";
        }
        //добавление
        public void AddList(CoefOfSafety roadworks)
        {
            roadList.Add(roadworks);
        }
        //удаление по экземляру класса
        public static void RemoveRoadList(CoefOfSafety roadworks)
        {
            roadList.Remove(roadworks);
        }
        //удаление по индексу
        public static void RemoveRoadList(int index)
        {
            if (index >= 0 && index < roadList.Count)
            {
                roadList.Remove(roadList[index]);
            }
        }
        //удаление по полям
        public static void RemoveRoadList(double width, double lenght, double roadMass, string locate, string type, double p)
        {
            var toRemove = roadList.FindLast(r => r.width == width && r.lenght == lenght && r.roadMass == roadMass && r.locate == locate && r.type == type && r.P == p);
            if (toRemove != null)
                roadList.Remove(toRemove);
            else MessageBox.Show("не найдено");
        }
        //новый метод,поиск по типу покрытия
        public static string SearchType(string type)
        {
            string answer = "";
            var toSearchType = roadList.FindAll(s => s.type == type);

            foreach (var item in toSearchType)
            {
                answer += item.GetInfo() + "\n";
            }
            return answer;
        }
    }

}
