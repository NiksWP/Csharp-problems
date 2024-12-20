using System.Text;

namespace SharkTaxonomy
{
	public class Shark
	{
		public Shark(string kind, int length, string food, string habitat)
		{
			this.Kind = kind;
			this.Length = length;
			this.Food = food;
			this.Habitat = habitat;
		}

		public string Kind { get; set; }
		public int Length { get; set; }
		public string Food { get; set; }
		public string Habitat { get; set; }

		public override string ToString()
		{
			return $"{this.Kind} shark: {this.Length}m long.\nCould be spotted in the {this.Habitat}, typical menu: {this.Food}";
		}

	}
}
