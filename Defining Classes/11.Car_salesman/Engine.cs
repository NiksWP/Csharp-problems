using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman
{
	public class Engine
	{
		private string model;
		private int power;
		private int displacement;
		private string efficiency;

		public Engine(string model, int power)
		{
			this.Model = model;
			this.Power = power;
		}

		public string Model
		{
			get
			{
				return this.model;
			}
			set
			{
				this.model = value;
			}
		}
		public int Power
		{
			get
			{
				return this.power;
			}
			set
			{
				this.power = value;
			}
		}
		public int Displacement
		{
			get
			{
				return this.displacement;
			}
			set
			{
				this.displacement = value;
			}
		}
		public string Efficiency
		{
			get
			{
				return this.efficiency;
			}
			set
			{
				this.efficiency = value;
			}
		}
	}
}
