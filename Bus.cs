using System;

namespace Exceptions
{
    class Bus
    {
        private string driverName;
        private string route;

        public void SetDriverName(string driverName) {
            if (driverName == null || driverName == "")
            {
                throw new ArgumentException("driverName is required");
            }
            if (driverName.Contains(" "))
            {
                throw new ArgumentException("driverName should have a name only");
            }
            this.driverName = driverName;
        }

        public void SetRoute(string route) {
            if (route.Length > 1)
            {
                throw new ArgumentException("route should only have one letter");    
            }
            this.route = route;
        }

        public void BeginRoute() {
            if (this.driverName == null)
            {
                throw new InvalidOperationException("Bus can't begin its route without a driver");
            }
            if (this.route == null)
            {
                throw new InvalidOperationException("Bus must have a route defined");
            }
            System.Console.WriteLine($"Begin route: {this.route}");
        }
    }
}
