﻿using Microsoft.JSInterop;

namespace LearnBlazor.Extensions;

public static class IJSRuntimeExtensions
{
    public static async Task ToastrSuccess(this IJSRuntime jSRuntime, string message)
    {
        await jSRuntime.InvokeVoidAsync("showToastr", "success", message);
    }

    public static async Task ToastrError(this IJSRuntime jSRuntime, string message)
    {
        await jSRuntime.InvokeVoidAsync("showToastr", "error", message);
    }
}
