﻿namespace Decorations.Models.Entity;

public class Address
{
    public int Id { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    
    public int ShopId { get; set; }
    public Shop Shop { get; set; }
}