using FluxorBlazorWeb.ReduxDevToolsTutorial.Shared;
using System.Collections.Generic;

namespace FluxorBlazorWeb.ReduxDevToolsTutorial.Client.Store.WeatherUseCase
{
	public class WeatherState
	{
		public bool IsLoading { get; }
		public IEnumerable<WeatherForecast> Forecasts { get; }

		public WeatherState(bool isLoading, IEnumerable<WeatherForecast> forecasts)
		{
			IsLoading = isLoading;
			Forecasts = forecasts;
		}
	}
}
