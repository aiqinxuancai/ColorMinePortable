








//Note: This is a generated file.
using ColorMine.ColorSpaces.Conversions;

namespace ColorMine.ColorSpaces
{

	public interface IRgb : IColorSpace
    {

		double R { get; set; }

		double G { get; set; }

		double B { get; set; }

    }

    public class Rgb : ColorSpace, IRgb
    {

		public double R { get; set; }

		public double G { get; set; }

		public double B { get; set; }


        public override void Initialize(IRgb color)
        {
            RgbConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return RgbConverter.ToColor(this);
        }

        public int ToInt32()
        {
            byte[] bytes = new byte[4];
            bytes[0] = (byte)(int)R;
            bytes[1] = (byte)(int)G;
            bytes[2] = (byte)(int)B;
            return System.BitConverter.ToInt32(bytes, 0);
        }

        public static Rgb Parse(int color)
        {
            Rgb rgb = new Rgb();
            byte[] bytes = System.BitConverter.GetBytes(color);
            rgb.R = bytes[0];
            rgb.G = bytes[1];
            rgb.B = bytes[2];

            return rgb;
        }



        #region Equality members

        public bool Equals(Rgb other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.R == R && other.G == G && other.B == B;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Rgb)obj);
        }

        public override int GetHashCode()
        {
            return $"{R}.{G}.{B}".GetHashCode();
        }

        public override string ToString()
        {
            return ToInt32().ToString();
        }

        #endregion
    }


    public interface IXyz : IColorSpace
    {

		double X { get; set; }

		double Y { get; set; }

		double Z { get; set; }

    }

    public class Xyz : ColorSpace, IXyz
    {

		public double X { get; set; }

		public double Y { get; set; }

		public double Z { get; set; }


        public override void Initialize(IRgb color)
        {
            XyzConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return XyzConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Xyz other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.X == X && other.Y == Y && other.Z == Z;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Xyz)obj);
        }

        public override int GetHashCode()
        {
            return $"{X}-{Y}-{Z}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'X':{X}, 'Y':{Y}, 'Z':{Z}}}".ToString();
        }

        #endregion
    }


    public interface IHsl : IColorSpace
    {

		double H { get; set; }

		double S { get; set; }

		double L { get; set; }

    }

    public class Hsl : ColorSpace, IHsl
    {

		public double H { get; set; }

		public double S { get; set; }

		public double L { get; set; }


        public override void Initialize(IRgb color)
        {
            HslConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return HslConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Hsl other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.H == H && other.S == S && other.L == L;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Hsl)obj);
        }

        public override int GetHashCode()
        {
            return $"{H}-{S}-{L}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'H':{H}, 'S':{S}, 'L':{L}}}".ToString();
        }

        #endregion
    }


    public interface ILab : IColorSpace
    {

		double L { get; set; }

		double A { get; set; }

		double B { get; set; }

    }

    public class Lab : ColorSpace, ILab
    {

		public double L { get; set; }

		public double A { get; set; }

		public double B { get; set; }


        public override void Initialize(IRgb color)
        {
            LabConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return LabConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Lab other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.L == L && other.A == A && other.B == B;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Lab)obj);
        }

        public override int GetHashCode()
        {
            return $"{L}-{A}-{B}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'L':{L}, 'A':{A}, 'B':{B}}}".ToString();
        }

        #endregion
    }


    public interface ILch : IColorSpace
    {

		double L { get; set; }

		double C { get; set; }

		double H { get; set; }

    }

    public class Lch : ColorSpace, ILch
    {

		public double L { get; set; }

		public double C { get; set; }

		public double H { get; set; }


        public override void Initialize(IRgb color)
        {
            LchConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return LchConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Lch other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.L == L && other.C == C && other.H == H;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Lch)obj);
        }

        public override int GetHashCode()
        {
            return $"{L}-{C}-{H}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'L':{L}, 'C':{C}, 'H':{H}}}".ToString();
        }

        #endregion
    }


    public interface ILuv : IColorSpace
    {

		double L { get; set; }

		double U { get; set; }

		double V { get; set; }

    }

    public class Luv : ColorSpace, ILuv
    {

		public double L { get; set; }

		public double U { get; set; }

		public double V { get; set; }


        public override void Initialize(IRgb color)
        {
            LuvConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return LuvConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Luv other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.L == L && other.U == U && other.V == V;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Luv)obj);
        }

        public override int GetHashCode()
        {
            return $"{L}-{U}-{V}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'L':{L}, 'U':{U}, 'V':{V}}}".ToString();
        }

        #endregion
    }


    public interface IYxy : IColorSpace
    {

		double Y1 { get; set; }

		double X { get; set; }

		double Y2 { get; set; }

    }

    public class Yxy : ColorSpace, IYxy
    {

		public double Y1 { get; set; }

		public double X { get; set; }

		public double Y2 { get; set; }


        public override void Initialize(IRgb color)
        {
            YxyConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return YxyConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Yxy other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.Y1 == Y1 && other.X == X && other.Y2 == Y2;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Yxy)obj);
        }

        public override int GetHashCode()
        {
            return $"{Y1}-{X}-{Y2}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'Y1':{Y1}, 'X':{X}, 'Y2':{Y2}}}".ToString();
        }

        #endregion
    }


    public interface ICmy : IColorSpace
    {

		double C { get; set; }

		double M { get; set; }

		double Y { get; set; }

    }

    public class Cmy : ColorSpace, ICmy
    {

		public double C { get; set; }

		public double M { get; set; }

		public double Y { get; set; }


        public override void Initialize(IRgb color)
        {
            CmyConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return CmyConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Cmy other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.C == C && other.M == M && other.Y == Y;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Cmy)obj);
        }

        public override int GetHashCode()
        {
            return $"{C}-{M}-{Y}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'C':{C}, 'M':{M}, 'Y':{Y}}}".ToString();
        }

        #endregion
    }


    public interface ICmyk : IColorSpace
    {

		double C { get; set; }

		double M { get; set; }

		double Y { get; set; }

		double K { get; set; }

    }

    public class Cmyk : ColorSpace, ICmyk
    {

		public double C { get; set; }

		public double M { get; set; }

		public double Y { get; set; }

		public double K { get; set; }


        public override void Initialize(IRgb color)
        {
            CmykConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return CmykConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Cmyk other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.C == C && other.M == M && other.Y == Y && other.K == K;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Cmyk)obj);
        }

        public override int GetHashCode()
        {
            return $"{C}-{M}-{Y}-{K}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'C':{C}, 'M':{M}, 'Y':{Y}, 'K':{K}}}".ToString();
        }
        #endregion
    }


    public interface IHsv : IColorSpace
    {

		double H { get; set; }

		double S { get; set; }

		double V { get; set; }

    }

    public class Hsv : ColorSpace, IHsv
    {

		public double H { get; set; }

		public double S { get; set; }

		public double V { get; set; }


        public override void Initialize(IRgb color)
        {
            HsvConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return HsvConverter.ToColor(this);
        }

        public static Hsv Parse(double H, double S, double V)
        {
            Hsv hsv = new Hsv();
            hsv.H = H;
            hsv.S = S;
            hsv.V = V;
            return hsv;
        }

        #region Equality members

        public bool Equals(Hsv other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.H == H && other.S == S && other.V == V;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Hsv)obj);
        }

        public override int GetHashCode()
        {
            return $"{H}-{S}-{V}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'H':{H}, 'S':{S}, 'V':{V}}}".ToString();
        }
        #endregion
    }


    public interface IHsb : IColorSpace
    {

		double H { get; set; }

		double S { get; set; }

		double B { get; set; }

    }

    public class Hsb : ColorSpace, IHsb
    {

		public double H { get; set; }

		public double S { get; set; }

		public double B { get; set; }


        public override void Initialize(IRgb color)
        {
            HsbConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return HsbConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(Hsb other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.H == H && other.S == S && other.B == B;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((Hsb)obj);
        }

        public override int GetHashCode()
        {
            return $"{H}-{S}-{B}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'H':{H}, 'S':{S}, 'B':{B}}}".ToString();
        }
        #endregion
    }


    public interface IHunterLab : IColorSpace
    {

		double L { get; set; }

		double A { get; set; }

		double B { get; set; }

    }

    public class HunterLab : ColorSpace, IHunterLab
    {

		public double L { get; set; }

		public double A { get; set; }

		public double B { get; set; }


        public override void Initialize(IRgb color)
        {
            HunterLabConverter.ToColorSpace(color,this);
        }

        public override IRgb ToRgb()
        {
            return HunterLabConverter.ToColor(this);
        }

        #region Equality members

        public bool Equals(HunterLab other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            if (ReferenceEquals(this, other))
            {
                return true;
            }
            return other.L == L && other.A == A && other.B == B;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }
            if (ReferenceEquals(this, obj))
            {
                return true;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            return Equals((HunterLab)obj);
        }

        public override int GetHashCode()
        {
            return $"{L}-{A}-{B}".GetHashCode();
        }

        public override string ToString()
        {
            return $"{{'L':{L}, 'A':{A}, 'B':{B}}}".ToString();
        }
        #endregion
    }


}