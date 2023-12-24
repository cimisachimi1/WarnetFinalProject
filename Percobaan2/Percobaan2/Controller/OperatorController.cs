using System.Collections.Generic;
using Percobaan2.Model.Entity;
using Percobaan2.Model.Context;
using Percobaan2.Model.Repository;

namespace Percobaan2.Controller
{
    public class OperatorController
    {
        private readonly OperatorRepository _repository;

        // Constructor
        public OperatorController()
        {
            // create the repository with the context
            _repository = new OperatorRepository(new DbContext());
        }

        public List<Operator> ReadAll()
        {
            // membuat objek collection
            List<Operator> list = new List<Operator>();

            try
            {
                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }
            catch (Exception ex)
            {
                // Log or handle the exception appropriately
                Console.WriteLine($"Error in ReadAll: {ex.Message}");
            }

            return list;
        }
    }
}
