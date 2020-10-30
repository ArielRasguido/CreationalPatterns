using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class OnlineStore
    {
        private PaymentMethodFactory factory = new ConcretePayMethodFactory();

        private List<IPaymentMethod> paymentMethods = new List<IPaymentMethod>() { };

        public void ShowStore()
        {
            int option;
            do
            {
                Console.WriteLine("-----Online Store (Admin View)------");
                Console.WriteLine("1. Cobrar");
                Console.WriteLine("2. Anadir Metodo de cobro");
                Console.WriteLine("0. Salir");
                Console.Write("Ingrese una opcion:");
                option = Convert.ToInt16(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Charge();
                        break;
                    case 2:
                        AddPaymentMethod();
                        break;
                    default:
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (option != 0);

        }


        public void AddPaymentMethod()
        {
            string method;
            Console.Write("Introducir el metodo de cobro a anadir (paypal,credit card):");
            method = Console.ReadLine();
            try
            {
                IPaymentMethod newMethod = factory.CreatePaymentMethod(method);
                paymentMethods.Add(newMethod);
                Console.WriteLine("Se anadio el metodo exitosamente!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
           
        }

        public void Charge()
        {
            int option;
            double amount;
            Console.WriteLine("Elegir metodo de cobro:");
            if (paymentMethods.Count > 0)
            {
                for (int i = 0; i < paymentMethods.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + paymentMethods[i].getName());
                }
                Console.Write("Elija una opcion:");
                option = Convert.ToInt16(Console.ReadLine());
                Console.Write("Introduzca la cantidad a cobrar:");
                amount = Convert.ToInt16(Console.ReadLine());
                paymentMethods[option - 1].charge(amount);
            }
            else
            {
                Console.WriteLine("Actualmente no existen metodos de cobro...");
            }

        }



    }
}
