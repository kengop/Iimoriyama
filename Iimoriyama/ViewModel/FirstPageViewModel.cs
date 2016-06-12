using iimoriyama_pcl;
using Prism.Commands;
using Prism.Mvvm;
using System.Windows.Input;

namespace Iimoriyama.ViewModel
{
	public class FirstPageViewModel : BindableBase
	{
		private int _input;
		public int Input
		{
			get
			{
				return this._input;
			}
			set
			{
				this._input = value;
				this.OnPropertyChanged(() => this.Input);
			}
		}

		private string _result;
		public string Result
		{
			get
			{
				return this._result;
			}
			set
			{
				this._result = value;
				this.OnPropertyChanged(() => this.Result);
			}
		}


		private ICommand _fizzBuzzComamnd;
		public ICommand FizzBuzzCommand
		{
			get
			{
				return this._fizzBuzzComamnd;
			}
		}
		private FizzBuzz _fb;

		public FirstPageViewModel()
		{
			this._fb = new FizzBuzz();
			this._fizzBuzzComamnd = new DelegateCommand(() =>
			{
				var result = _fb.Game(this.Input);
				this.Result = result;
			},
			() =>
			{
				return this.Input >= 0;
			}
			);
		}
	}
}
