using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms; 
using Percobaan2.Model.Repository;
using Percobaan2.Model.Context;
using Percobaan2.Model.Entity;

namespace Percobaan2.Controller
{
    public class PelangganController
    {
        private AkunPelangganRepository? _repository;
        public List<AkunPelanggan> ReadAll()
        {
            // membuat objek collection
            List<AkunPelanggan> list = new List<AkunPelanggan>();

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek dari class repository
                _repository = new AkunPelangganRepository(context);

                // panggil method GetAll yang ada di dalam class repository
                list = _repository.ReadAll();
            }

            return list;
        }
    }

}
