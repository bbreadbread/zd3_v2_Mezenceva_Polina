using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zd3_v2_Mezenceva_Polina
{
    class CoefOfSafety : Roadworks
    {
        public double P { get; set; } //коэффициент прочности

        //дополнительные свойства
        public string year { get; set; } //год постройки
        public double traffic { get; set; } //трафик движения
        public string serviceLife { get; set; } //срок эксплуатации

        //конструктор
        public CoefOfSafety(double width, double length, double roadMass,
            string location, string type, double p, string year, double traffic, string serviceLife)
            : base(width, length, roadMass, location, type)
        {
            P = p; //инициализация P
            this.year = year;
            this.traffic = traffic;
            this.serviceLife = serviceLife;
        }

        //метод для расчета качества
        public double Qp()
        {
            if (P >= 5 && P <= 8) return Q() * 1.1;
            else if (P == 3 || P == 4 || P == 9 || P == 10) return Q() * 1.6;
            else return Q() * 1.9;
        }
    }
}
