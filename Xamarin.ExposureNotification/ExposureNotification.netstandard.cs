﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Xamarin.ExposureNotifications
{
	public static partial class ExposureNotification
	{
		static Task PlatformStart()
			=> throw new PlatformNotSupportedException();

		static Task PlatformStop()
			=> throw new PlatformNotSupportedException();

		static Task<bool> PlatformIsEnabled()
			=> throw new PlatformNotSupportedException();

		static async Task PlatformScheduleFetch()
			=> throw new PlatformNotSupportedException();

		static Task<(ExposureDetectionSummary, IEnumerable<ExposureInfo>)> PlatformDetectExposuresAsync(IEnumerable<TemporaryExposureKey> diagnosisKeys)
			=> throw new PlatformNotSupportedException();

		static Task<IEnumerable<TemporaryExposureKey>> PlatformGetTemporaryExposureKeys()
			=> throw new PlatformNotSupportedException();
	}
}
