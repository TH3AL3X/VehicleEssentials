using Rocket.API;

namespace VehicleCrash
{
    public class VehicleConfig : IRocketPluginConfiguration
    {

        public byte healthdamage;

        public bool nausea;

        public float nauseatime;

        public bool wheelsdamage;

        public bool autowarnmechanic;

        public float wheelchancedamage;

        public ushort ifvehiclehasXhealthStopWork;

        public void LoadDefaults()
        {
            nausea = true;

            ifvehiclehasXhealthStopWork = 248;

            nauseatime = 10;

            healthdamage = 11;

            wheelsdamage = true;

            wheelchancedamage = .45f; // this means 45% nigga

            autowarnmechanic = true;
        }
    }
}
