using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_6BiblWorm
{
    class Journal : Item
    {
        private string title;             // Название
        private string editor;            // Редактор
        private int pages;                // Количество страниц
        private int yearOfRelease;        // Год выпуска
        private bool existence;           // Наличие
        private bool sortInvNumber;       // Сортировка по инвентарному номеру
        /*private bool returnTime;          */// Возвращение в срок
        private int periodUse;            // Срок пользования

        private double cust;
        private bool returnSrok;

        private static double price = 9;  // Стоимость аренды

        static Journal()
        {
            price = 50;  // Установка статической цены для журнала
        }

        public Journal(string title, string editor, int pages, int yearOfRelease, long invNumber, bool taken)
            : base(invNumber, taken)
        {
            this.title = title;
            this.editor = editor;
            this.pages = pages;
            this.yearOfRelease = yearOfRelease;
        }

        public Journal()
        { }

        public static void SetPrice(double price)
        {
            Journal.price = price;
        }

        public override string ToString()
        {
            string status = existence ? "в наличии" : "отсутствует";
            return $"\nЖурнал:\n Название: {title}\n Редактор: {editor}\n Количество страниц: {pages}\n Год выпуска: {yearOfRelease}\n Стоимость аренды: {Journal.price} p.\n Наличие: {status}\n Срок пользования: {periodUse} дней\n{base.ToString()}";
        }

        public void PriceJournal(int s)
        {

            if (this.returnSrok == true)
                this.cust = s * price;
            else this.cust = s * (price + price * 0.13); ;

        }

        public void ReturnSrok()
        {
            returnSrok = true;
        }

        public override void Return()
        {
            if (returnSrok == true)
                taken = true;
            else
                taken = false;
        }
    }
}