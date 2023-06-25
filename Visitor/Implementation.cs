namespace Visitor
{
    /// <summary>
    /// ConcreteElement
    /// </summary>
    public class Customer : IElement
    {
        public string Name { get; private set; }
        public decimal AmountOrdered { get; private set; }
        public decimal Discount { get; set; }

        public Customer(string name, decimal amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            //visitor.VisitCustomer(this);
            visitor.Visit(this);
            Console.WriteLine($"Visited {nameof(Customer)} {Name}, " +
                $"discount given: {Discount}");
        }
    }

    /// <summary>
    /// ConcreteElement
    /// </summary>
    public class Employee : IElement
    {
        public string Name { get; private set; }
        public int YearsEmployed { get; private set; }
        public decimal Discount { get; set; }

        public Employee(string name, int yearsEmployed)
        {
            Name = name;
            YearsEmployed = yearsEmployed;
        }

        public void Accept(IVisitor visitor)
        {
            //visitor.VisitEmployee(this);
            visitor.Visit(this);
            Console.WriteLine($"Visited {nameof(Employee)} {Name}, " +
                $"discount given: {Discount}");
        }
    }

    ///// <summary>
    ///// Visitor
    ///// </summary>
    //public interface IVisitor
    //{
    //    void VisitCustomer(Customer customer);
    //    void VisitEmployee(Employee employee);
    //}

    /// <summary>
    /// Visitor (alternative)
    /// </summary>
    public interface IVisitor
    {
        void Visit(IElement element);
    }

    /// <summary>
    /// Element
    /// </summary>
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    /// <summary>
    /// ConcreteVisitor
    /// </summary>
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountGiven { get; set; }

        public void Visit(IElement element)
        {
            if (element is Customer customer)
                VisitCustomer(customer);
            else if (element is Employee employee)
                VisitEmployee(employee);
        }

        private void VisitCustomer(Customer customer)
        {
            // Percentage of total amount
            var discount = customer.AmountOrdered / 10;
            // Set it on the customer
            customer.Discount = discount;
            // Add it to the total amount
            TotalDiscountGiven += discount;
        }

        private void VisitEmployee(Employee employee)
        {
            // Fixed value depending on the amount of years employed
            var discount = employee.YearsEmployed < 10 ? 100 : 200;
            // Set it on the employee
            employee.Discount = discount;
            // Add it to the total amount
            TotalDiscountGiven += discount;
        }
    }

    /// <summary>
    /// ObjectStructure
    /// </summary>
    public class Container
    {
        public List<Employee> Employees { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();

        public void Accept(IVisitor visitor)
        {
            foreach (var employee in Employees)
            {
                employee.Accept(visitor);
            }
            foreach (var customer in Customers)
            {
                customer.Accept(visitor);
            }
        }
    }
}
