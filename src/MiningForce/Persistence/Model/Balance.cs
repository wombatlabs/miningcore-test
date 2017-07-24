﻿using System;
using MiningForce.Configuration;

namespace MiningForce.Persistence.Model
{
	public class Balance
	{
		public CoinType Coin { get; set; }
		public string Wallet { get; set; }
		public double Amount { get; set; }
		public DateTime Created { get; set; }
		public DateTime Updated { get; set; }
	}
}