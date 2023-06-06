using MudBlazorCrudST.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazorCrudST.IService
{
	public interface IAnimalService
	{
		HashSet<Animal> GetAnimals();
		Animal GetById(int animalId);
		void Save(Animal animal);
		string Delete(int animalId);
		void UpdateAll(List<Animal> animals);
	}
}
