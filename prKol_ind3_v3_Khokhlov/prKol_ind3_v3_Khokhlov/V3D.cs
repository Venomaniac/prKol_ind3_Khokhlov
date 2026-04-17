using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind3_v3_Khokhlov
{
    internal class V3D
    {
        private ArrayList coordinates;
        public V3D(double x, double y, double z)
        {
            coordinates = new ArrayList();
            coordinates.Add(x);
            coordinates.Add(y);
            coordinates.Add(z);
        }
        public V3D() : this(0, 0, 0) { }
        public double X
        {
            get { return (double)coordinates[0]; }
            set { coordinates[0] = value; }
        }

        public double Y
        {
            get { return (double)coordinates[1]; }
            set { coordinates[1] = value; }
        }

        public double Z
        {
            get { return (double)coordinates[2]; }
            set { coordinates[2] = value; }
        }
        public V3D Add(V3D other)
        {
            return new V3D(X + other.X, Y + other.Y, Z + other.Z);
        }
        public V3D Subtract(V3D other)
        {
            return new V3D(X - other.X, Y - other.Y, Z - other.Z);
        }
        public double DotProduct(V3D other)
        {
            return X * other.X + Y * other.Y + Z * other.Z;
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }
        public double CosAngle(V3D other)
        {
            double dot = DotProduct(other);
            double len1 = Length();
            double len2 = other.Length();
            if (len1 == 0 || len2 == 0)
                return 0;

            return dot / (len1 * len2);
        }
        public override string ToString()
        {
            return $"({X:F2}, {Y:F2}, {Z:F2})";
        }
    }
}
