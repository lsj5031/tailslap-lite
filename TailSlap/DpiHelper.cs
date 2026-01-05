using System;
using System.Drawing;

public static class DpiHelper
{
    private static float? _scaleFactor;

    public static float ScaleFactor
    {
        get
        {
            if (!_scaleFactor.HasValue)
            {
                try
                {
                    using var g = Graphics.FromHwnd(IntPtr.Zero);
                    _scaleFactor = g.DpiX / 96f;
                }
                catch
                {
                    _scaleFactor = 1f;
                }
            }
            return _scaleFactor.Value;
        }
    }

    public static int Scale(int value) => (int)Math.Round(value * ScaleFactor);

    /// <summary>
    /// Scale font size. Note: WinForms AutoScaleMode.Dpi already scales fonts,
    /// so this should only be used for fonts created manually outside of AutoScaleMode.
    /// For forms with AutoScaleMode.Dpi enabled, use the base point size directly.
    /// </summary>
    public static float ScaleFont(float basePt) => basePt;

    public static Size Scale(Size size) => new Size(Scale(size.Width), Scale(size.Height));

    public static Padding Scale(Padding padding) =>
        new Padding(
            Scale(padding.Left),
            Scale(padding.Top),
            Scale(padding.Right),
            Scale(padding.Bottom)
        );
}
