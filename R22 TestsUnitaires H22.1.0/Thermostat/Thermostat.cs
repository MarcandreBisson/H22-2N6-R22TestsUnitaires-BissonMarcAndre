using System;

namespace Thermostat
{
    /// <summary>
    /// Mod�lise un thermostat �lectronique contr�lant la temp�rature d'une pi�ce.
    /// </summary>
    public class Thermostat
    {
        #region Constantes
        /// ======= CHAMPS====== =================================
        public const int MIN_TEMPERATURE = 5;
        public const int MAX_TEMPERATURE = 35;
        public const int TEMPERATURE_INITIALE = 20;
        #endregion

        #region Propri�t�
        private int m_temperature;
        ///-------------------------------------------------------
        /// <summary>
        ///    Obtient ou d�finit la temp�rature du thermostat
        /// </summary>
        ///-------------------------------------------------------
        public int Temperature
        {
            get { return m_temperature; }
            set
            {
                if (value < MIN_TEMPERATURE || value > MAX_TEMPERATURE)
                    throw new ArgumentOutOfRangeException();

                m_temperature = value;
            }
        }
        #endregion

        #region Constructeur
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance 
        ///   � la temp�rature initiale. 
        /// </summary>
        ///------------------------------------------------------------
        public Thermostat()
        {
            Temperature = TEMPERATURE_INITIALE;
        }
        ///------------------------------------------------------------
        /// <summary>
        ///   Initialise une nouvelle instance  
        ///   � la temp�rature pTemperature. 
        /// </summary>
        /// <param name="pTemperature">
        ///------------------------------------------------------------
        public Thermostat(int pTemperature)
        {
            Temperature = pTemperature;
        }
        #endregion

        #region M�thodes
        ///-------------------------------------------------------
        /// <summary>
        ///   Augmente la temp�rature courante d'un degr�.
        /// </summary>
        ///-------------------------------------------------------
        public void AugmenterTemperature()
        {
            if (m_temperature == MAX_TEMPERATURE)
                throw new InvalidOperationException();
            Temperature++;
        }
        ///-------------------------------------------------------
        /// <summary>
        ///   Diminue la temp�rature courante d'un degr�.
        /// </summary>
        ///-------------------------------------------------------
        public void DiminuerTemperature()
        {
            if (m_temperature == MIN_TEMPERATURE)
                throw new InvalidOperationException();
            Temperature--;
        }
        #endregion
    }
}
