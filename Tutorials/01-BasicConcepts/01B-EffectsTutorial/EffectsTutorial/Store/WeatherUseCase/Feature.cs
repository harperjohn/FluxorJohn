using Fluxor;

namespace BasicConcepts.EffectsTutorial.Client.Store.WeatherUseCase
{
	public class Feature : Feature<WeatherState>
	{
		public override string GetName() => "Weather";
		protected override WeatherState GetInitialState() =>
			new WeatherState(
				isLoading: false,
				forecasts: null);
	}
}
