using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    abstract class Delivery
    {
        public abstract string DeliveryMethod { get; }

        public abstract double DeliveryCost { get; }

        public abstract void Deliver();
    }

    class FootCourierDelivery : Delivery
    {
        public override string DeliveryMethod => "Foot courier";

        public override double DeliveryCost => 5.0;

        public override void Deliver()
        {
            MessageBox.Show("Delivering your order by foot courier.");
        }
    }

    class TrolleyDelivery : Delivery
    {
        public override string DeliveryMethod => "Trolley";

        public override double DeliveryCost => 7.0;

        public override void Deliver()
        {
            MessageBox.Show("Delivering your order by trolley.");
        }
    }

    class MotorizedScooterDelivery : Delivery
    {
        public override string DeliveryMethod => "Motorized scooter";

        public override double DeliveryCost => 10.0;

        public override void Deliver()
        {
            MessageBox.Show("Delivering your order by motorized scooter.");
        }
    }

    class ScooterDelivery : Delivery
    {
        public override string DeliveryMethod => "Scooter";

        public override double DeliveryCost => 15.0;

        public override void Deliver()
        {
            MessageBox.Show("Delivering your order by scooter.");
        }
    }

    class CarDelivery : Delivery
    {
        public override string DeliveryMethod => "Car";

        public override double DeliveryCost => 20.0;

        public override void Deliver()
        {
            MessageBox.Show("Delivering your order by car.");
        }
    }

    abstract class DeliveryFactory
    {
        public abstract Delivery CreateDelivery(double orderSize);
    }

    class FoodDeliveryFactory : DeliveryFactory
    {
        public override Delivery CreateDelivery(double orderSize)
        {
            if (orderSize <= 5)
            {
                return new FootCourierDelivery();
            }
            else if (orderSize <= 10)
            {
                return new TrolleyDelivery();
            }
            else if (orderSize <= 20)
            {
                return new MotorizedScooterDelivery();
            }
            else if (orderSize <= 50)
            {
                return new ScooterDelivery();
            }
            else
            {
                return new CarDelivery();
            }
        }
    }
}
