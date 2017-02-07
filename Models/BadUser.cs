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
                throw new Exception("Age must be greater or equal to 13.")
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
        private void Update()
        {
            UpdatedAt = DateTime.UtcNow;
        }
    }
}