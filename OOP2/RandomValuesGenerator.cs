using OOP1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class RandomValuesGenerator
    {
        private static Random rnd = new Random();

        private static string[] cities =
        {
            "г. Москва, ", "г. Санкт-Петербург, ", "г. Новосибирск, ", "г. Екатеринбург, ", "г. Нижний Новгород, ",
            "г. Казань, ", "г. Челябинск, ", "г. Омск, ", "г. Самара, ", "г. Ростов-на-Дону, ",
            "г. Уфа, ", "г. Красноярск, ", "г. Воронеж, ", "г. Пермь, ", "г. Волгоград, ",
            "г. Краснодар, ", "г. Тюмень, ", "г. Ижевск, ", "г. Барнаул, ", "г. Ульяновск, ",
            "г. Владикавказ, ", "г. Астрахань, ", "г. Рязань, ", "г. Махачкала, ", "г. Саратов, ",
            "г. Калуга, ", "г. Тольятти, ", "г. Кемерово, ", "г. Тверь, ", "г. Ярославль, ",
            "г. Ставрополь, ", "г. Томск, ", "г. Мурманск, ", "г. Киров, ", "г. Курск, ",
            "г. Псков, ", "г. Пенза, ", "г. Тула, ", "г. Набережные Челны, ", "г. Сочи, ", "г. Белгород, ",
            "г. Арзамас, ", "г. Чита, ", "г. Братск, ", "г. Хабаровск, ", "г. Сургут, ",
            "г. Петрозаводск, ", "г. Брянск, ", "г. Кострома, ", "г. Липецк, ", "г. Иркутск, ",
            "г. Вологда, ", "г. Норильск, ", "г. Калининград, ", "г. Смоленск, ", "г. Муром, ",
            "г. Таганрог, ", "г. Балашиха, ", "г. Оренбург, ", "г. Петропавловск-Камчатский, ", "г. Тамбов, "
        };

        private static string[] streets =
        {
            "ул. Клары Цеткин, д. ", "ул. Ленина, д. ", "ул. Октябрьская, д. ", "ул. Пушкина, д. ", "ул. Гоголя, д. ",
            "ул. Мира, д. ", "ул. Советская, д. ", "ул. Победы, д. ", "ул. Тимирязева, д. ", "ул. Достоевского, д. ",
            "ул. Шевченко, д. ", "ул. Комсомольская, д. ", "ул. Кирова, д. ", "ул. Зои Космодемьянской, д. ", "ул. Гагарина, д. ",
            "ул. Космонавтов, д. ", "ул. Чехова, д. ", "ул. Степана Разина, д. ", "ул. Тракторная, д. ", "ул. Вокзальная, д. ",
            "ул. Урицкого, д. ", "ул. Советской Армии, д. ", "ул. Краснодонцев, д. ", "ул. Ярослава Мудрого, д. ", "ул. Тимирязева, д. ",
            "ул. Лермонтова, д. ", "ул. Морозова, д. ", "ул. Чернышевского, д. ", "ул. Гагарина, д. ", "ул. Пионерская, д. ",
            "ул. Бажова, д. ", "ул. Фрунзе, д. ", "ул. Котельникова, д. ", "ул. Калинина, д. ", "ул. Петрова, д. ",
            "ул. Красная, д. ", "ул. Нагорная, д. ", "ул. Пескова, д. ", "ул. Крылова, д. ", "ул. Вильнюсская, д. ",
            "ул. Бориса Гребенщикова, д. ", "ул. Энгельса, д. ", "ул. Розы Люксембург, д. ", "ул. Березина, д. ", "ул. Невская, д. ",
            "ул. Карла Маркса, д. ", "ул. Петровского, д. ", "ул. Братьев Карамазовых, д. ", "ул. Ломоносова, д. ", "ул. Маяковского, д. ",
            "ул. Островского, д. ", "ул. Казарина, д. ", "ул. Мичурина, д. ", "ул. Жукова, д. ", "ул. Архитектора Душкина, д. "
        };

        private static string[] types =
        {
            "Машинная",
            "Декадно-шаговая",
            "Координатная",
            "Квазиэлектронная",
            "Электронная аналоговая",
            "Электронная цифровая",
            "Интернет-АТС",
            "Программная"
        };

        private static string[] protocols =
        {
            "ISDN",
            "SIP",
            "H.323",
            "MGCP",
            "R2",
            "Q.SIG",
            "SCCP",
            "X.25",
            "VoIP",
            "PSTN",
            "T1/E1",
            "ISUP",
            "SS7",
            "SCTP"
        };

        public static string GetRandomAddress()
        {
            return $"{cities[rnd.Next(cities.Length)]}{streets[rnd.Next(streets.Length)]}{rnd.Next(1, 250)}";
        }

        public static string GetRandomType()
        {
            return types[rnd.Next(types.Length)];
        }

        public static DateTime GetRandomDateTime()
        {
            DateTime start = new DateTime(1891, 6, 10);
            DateTime end = DateTime.Now;
            return start.AddDays(rnd.Next((end - start).Days));
        }

        public static string[] GetRandomProtocols()
        {
            for(int i = protocols.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                string temp = protocols[i];
                protocols[i] = protocols[j];
                protocols[j] = temp;
            }
            int count = rnd.Next(2, 4);
            string[] randomprotocols = new string[count];
            for(int i =  0; i < count; i++)
            {
                randomprotocols[i] = protocols[i];
            }
            return randomprotocols;
        }

        public static bool GetRandomIsWorking()
        {
            return rnd.Next(2) == 1;
        }

        public static int GetRandomNumberOfUsers()
        {
            return rnd.Next(1, 150000);
        }

        public static decimal GetRandomPayment()
        {
            return (decimal)rnd.NextDouble() * 1000;
        }

        public static TelephoneExchange CreateRandomTelephoneExchange()
        {
            return new TelephoneExchange
                (
                    GetRandomAddress(),
                    GetRandomNumberOfUsers(),
                    GetRandomPayment(),
                    GetRandomType(),
                    GetRandomProtocols(),
                    GetRandomDateTime(),
                    GetRandomIsWorking()
                );
        }
    }
}
