﻿namespace FreeCourse.WebUI.Models.Orders
{
    public class OrderCreatedViewModel
    {
        public int OrderId { get; set; }

        public string Error { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
