using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling___CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            try
            {
                DifferentMethos();
                name = "Jyotirmoy";
                ComplexMethod(name);
                simpleMethod();
            }
            catch(NotImplementedException ex)
            {
                Console.WriteLine("You forgot to write your code!");
            }
            catch(InvalidOperationException ex)
            {
                Console.WriteLine("You should not be running these methods!!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception) when (name.ToLower() == "jyotirmoy")
            {
                Console.WriteLine("You used the name Jyotirmoy, Didn't you?");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("I always run!!");
            }
            Console.ReadLine();
        }

        private static void ComplexMethod(string name)
        {
            if (name.ToLower() == "jyotirmoy")
            {
                throw new InsufficientMemoryException("Jyotirmoy is too tall for this method!!");
            }
            else
            {
                throw new ArgumentException("This person isn't Jyotirmoy");
            }
        }

        private static void DifferentMethos()
        {
            Console.WriteLine("This method is working fine!");
            //throw new NotImplementedException();
        }

        private static void simpleMethod ()
        {
            throw new InvalidOperationException("This method named as simpleMethod() should not be called!!");
        }
    }
}
