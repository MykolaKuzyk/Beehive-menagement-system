using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Beehive_menagement_system
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = .19f;
        public const float LOW_LEVEL_WARNING = 10f;


        private static float honey = 25f;
        private static float nectar = 100f; // all the nectar 
        /// <summary>
        /// creates a report and warning messages 
        /// </summary>
        private static string StatusReport 
        { get 
            {
                if (honey < LOW_LEVEL_WARNING) {
                    return $"Vault report/n {honey} units of honey/n {nectar} units of nectar /n LOW_LEVEL_WARNING - ADD A HONEY MANUFACTURER";
                } // if honey > LOW_LEVEL_WARNING = no warning 
                else if (nectar < LOW_LEVEL_WARNING) {
                    return $"Vault report/n {honey} units of honey/n {nectar} units of nectar /n LOW_LEVEL_WARNING - ADD A NECTAR MANUFACTURER";
                }
                 else { return $"Vault report/n {honey} units of honey/n {nectar} units of nectar"; }
            } 
        }
        /// <summary>
        /// ConverNectarToHoney method converts nectra to honey using 
        /// NECTAR_CONVERSION_RATIO * amount 
        /// if amount passed to the method is less than nectar in Vault that convert all the nectar 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        private static float ConverNectarToHoney(float amount)
        {
            if (amount < nectar)
            {
                amount = nectar + amount;
                honey = amount * NECTAR_CONVERSION_RATIO;
            }
            else
            {
                honey = amount * NECTAR_CONVERSION_RATIO;
            }
            return honey;
        }
        /// <summary>
        /// This method consumes honey 
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public static bool ConsumeHoney(float amount)
        {
            if (amount > honey)
            {
                honey = honey - amount;
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void  CollectNectar(float amount)
        {
            if (amount > 0)
            {
                honey += amount;
            }
            else
            {
                Debug.WriteLine("nothing to add");
               
            }
        }
       


    }
    
}
