using System;

namespace Program_1.Models
{
    public class User
    {
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; private set; }
        public bool IsActive { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public decimal Founds { get; private set; }

        public User(string email, string password)
        {
            SetEmail(email);
            SetPassword(password);
        }
        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new Exception("Email is incorect.");
            }
            if (Email == email)
            {
                return;
            }
            Email = email;
            Update();
        }

         public void SetPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
            {
                throw new Exception("Password is incorect.");
            }
            if (Email == password)
            {
                return;
            }
            Email = password;
            Update();
        }

        public void SetAge(int age)
        {
            if (age < 13)
            {
                throw new Exception("Age must be greater or equal to 13.");
            }
            if (Age == age)
            {
                return;
            }
            Age = age;
            Update();
        }

        public void Activate()
        {

        if (IsActive)
        {
            return;
        }
        IsActive = true;
        Update();
        }

        public void Deactive()
        {
            if (!IsActive)
            {
                return;
            }
            IsActive = false;
            Update();
        }

        public void IncreaseFounds(decimal founds)
        {
            if (founds <= 0) throw new Exception("Founds must be greater then 0.");
            Founds += founds;
            Update();
        }
        
        public void PurchareOrder(Order order)
        {
            if (!IsActive)
            {
                throw new Exception("Only active users can purchase an order.");
            }

            decimal orderPrice = order.TotalPrice;
            if (Founds - orderPrice < 0) throw new Exception("You don't have enauh money!");

            order.Purchase();

            Founds -= orderPrice;
            Update();
        }
        private void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}