using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Inter : Phonebook
    {
        public void DoOperation()
        {
            View view = new View();
            Phonebook pb = new Phonebook();


            Boolean check = true;
            while (check)
            {
                Console.WriteLine("1. Добавить контакт.\n2. Удалить контакт.\n3. Поиск контакта по ключевому слову или номеру." +
                    "\n4. Показать все контакты.\n5. Выйти из приложения.\n\n");
                switch (view.getNum())
                {
                    case 1:
                        Console.WriteLine("Введите ID, имя, телефонный номер, адресс, электронный адрес контакта: ");
                        pb.AddContact(new Contact(view.getLine(), view.getLine(), view.getLine(), view.getLine(), view.getLine()));
                        break;
                    case 2:
                        Console.WriteLine("Введите ID или имя контакта для его удаления: ");
                        pb.DeleteContact(pb.SearchByKey(view.getLine(), pb.contacts));
                        break;
                    case 3:
                        Console.WriteLine("Введите ключевое слово или номер телефона контакта для его поиска: ");
                        pb.ShowOne(pb.SearchByKey(view.getLine(), pb.contacts));
                        break;
                    case 4:
                        pb.Show();
                        break;
                    case 5:
                        check = false;
                        break;
                }

            }
        }

    }
}
