using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace IWorkerhive_menagement_system
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
        public static string StatusReport 
        { get 
            {
                if (honey < LOW_LEVEL_WARNING) {
                    return $"\n{honey} units of honey\n{nectar} units of nectar \n LOW_LEVEL_WARNING - ADD A HONEY MANUFACTURER";
                } // if honey > LOW_LEVEL_WARNING = no warning 
                else if (nectar < LOW_LEVEL_WARNING) {
                    return $"\n{honey} units of honey\n{nectar} units of nectar \n LOW_LEVEL_WARNING - ADD A NECTAR MANUFACTURER";
                }
                 else { return $"\n{honey} units of honey\n{nectar} units of nectar"; }
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
            float nectarToConvert = amount;
            if (nectarToConvert > nectar)
            {
                nectarToConvert = nectar;

            }
            else
            {
                honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
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
            if (honey >= amount)
            {
                honey -= amount;
                return true;
            }
            else
            {
                Debug.WriteLine("nothing to add");
                return false;
            }
        }
        public static void  CollectNectar(float amount)
        {
            if (amount > 0f)
            {
                nectar += amount;
            }
            else
            {
                Debug.WriteLine("nothing to add");
               
            }
        }
       


    }
    
}
