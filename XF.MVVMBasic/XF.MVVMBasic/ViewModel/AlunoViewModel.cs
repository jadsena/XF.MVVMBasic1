using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XF.MVVMBasic.Model;

namespace XF.MVVMBasic.ViewModel
{
    public class AlunoViewModel 
    {
        public static ObservableCollection<AlunoViewModel> Alunos = new ObservableCollection<AlunoViewModel>();
        #region Propriedades
        public Aluno AlunoModel { get; set; }
        #endregion
        public AlunoViewModel(Aluno aluno)
        {
            this.AlunoModel = aluno;
        }

        public AlunoViewModel()
        {
            //var aluno = GetAluno();
            //this.RM = aluno.RM;
            //this.Nome = aluno.Nome;
            //this.Email = aluno.Email;
        }
        private Aluno GetAluno()
        {
            var aluno = new Aluno()
            {
                Id = Guid.NewGuid(),
                RM = "542621",
                Nome = "Anderson Silva",
                Email =
           "anderson@ufc.com"
            };
            return aluno;
        }

        //public List<Aluno> GetAlunos()
        //{
        //    List<Aluno> alunos = new List<Aluno>();
        //    for(int i = 0; i < 10; i++)
        //    {
        //        alunos.Add(new Aluno() {
        //            Id = Guid.NewGuid(),
        //            Email = $"email{i}@fiap.com.br",
        //            Nome = $"Aluno {i}",
        //            RM = $"{i}{i+3}{i+7}{i+i}"
        //        });
        //    }
        //    return alunos;
        //}

    }
}