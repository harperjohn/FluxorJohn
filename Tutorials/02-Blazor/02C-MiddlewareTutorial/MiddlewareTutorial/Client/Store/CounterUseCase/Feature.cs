using Fluxor;

namespace FluxorBlazorWeb.MiddlewareTutorial.Client.Store.CounterUseCase
{
	public class Feature : Feature<CounterState>
	{
		public override string GetName() => "Counter";
		protected override CounterState GetInitialState() => new CounterState(clickCount: 0);
	}
}
