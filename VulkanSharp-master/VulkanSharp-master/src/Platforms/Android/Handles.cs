/* Please note that this file is generated by the VulkanSharp's generator. Do not edit directly.

   Licensed under the MIT license.

   Copyright 2016 Xamarin Inc

   This notice may not be removed from any source distribution.
   See LICENSE file for licensing details.
*/

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;

namespace Vulkan.Android
{
	public static class InstanceExtension
	{
		public static SurfaceKhr CreateAndroidSurfaceKHR (this Instance instance, AndroidSurfaceCreateInfoKhr pCreateInfo, AllocationCallbacks pAllocator = null)
		{
			Result result;
			SurfaceKhr pSurface;
			unsafe {
				pSurface = new SurfaceKhr ();

				fixed (UInt64* ptrpSurface = &pSurface.m) {
					result = Android.Interop.NativeMethods.vkCreateAndroidSurfaceKHR (instance.m, pCreateInfo != null ? pCreateInfo.m : (Android.Interop.AndroidSurfaceCreateInfoKhr*)default(IntPtr), pAllocator != null ? pAllocator.m : null, ptrpSurface);
				}
				if (result != Result.Success)
					throw new ResultException (result);

				return pSurface;
			}
		}
	}

}