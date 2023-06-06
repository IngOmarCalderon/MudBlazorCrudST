using MudBlazorCrudST.Context;
using MudBlazorCrudST.Data;
using MudBlazorCrudST.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static MudBlazor.CategoryTypes;

namespace MudBlazorCrudST.Service
{
	public class AnimalService : IAnimalService
	{
		private readonly DatabaseContext _context;

		public AnimalService(DatabaseContext context)
		{
			_context = context;
		}

		public string Delete(int animalId)
		{
			//throw new NotImplementedException();
			var animal = _context.Animals.FirstOrDefault(x => x.AnimalId == animalId);
			if (animal != null) 
			{
				_context.Animals.Remove(animal);
				_context.SaveChanges();
			}
			return "Deleted";
		}

		public Animal GetById(int animalId)
		{
			//throw new NotImplementedException();
			return _context.Animals.SingleOrDefault(x => x.AnimalId == animalId);
		}

		public HashSet<Animal> GetAnimals()
		{
			//throw new NotImplementedException();
			return _context.Animals.ToHashSet();
		}

		public void Save(Animal animal)
		{
			//throw new NotImplementedException();
			if (animal.AnimalId == 0)
				_context.Animals.Add(animal);
			else
				_context.Animals.Update(animal);
			_context.SaveChanges();
		}

		public void UpdateAll(List<Animal> animals)
		{
			var oldValue = _context.Animals.Where(e => e.Selected).ToList();

			foreach (var itemOld in oldValue) 
			{
				if (!animals.Contains(itemOld)) 
				{
					itemOld.Selected = false;
					animals.Add(itemOld);
				}
			}

			foreach (var item in animals)
			{
				_context.Animals.Update(item);
			}
			_context.SaveChanges();
		}
	}
}
