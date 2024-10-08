﻿using System;
namespace ClothingAllowanceAppV2

{
	public class Purchase

	{

		private DateTime datePurchased;
		private string description;
		private float amount;

		public Purchase(DateTime date, string description, float amount)

		{
			datePurchased = date;
			this.description = description;
			this.amount = amount;
		}

		public DateTime GetDate()
		{
			return datePurchased;
		}

		public float GetAmount()
		{
			return amount;
		}
		public string purchaseSummary()

		{
			return datePurchased.ToString("dd/MM/yyyy") + "\t" + description + "\t" + amount;
		}

	}

}