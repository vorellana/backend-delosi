namespace data_structures_api.DTOs
{
    public class Matrix
    {
        public List<List<int>> Values { get; set; }

        public Matrix(List<List<int>> values)
        {
            Values = values;
        }

        public (bool, string) IsValid()
        {
            if (Values == null)
            {
                return (false, "La matriz es nula.");
            }

            if (Values.Count() == 0)
            {
                return (false, "La matriz no contiene elementos.");
            }

            if (Values.Count() == 1 && Values[0].Count() == 1)
            {
                return (false, "La matriz no puede contener solo un elemento.");
            }

            int n = Values.Count;

            for (int i = 0; i < n; i++)
            {
                if (Values[i] == null || Values[i].Count != n)
                {
                    return (false, "La matriz proporcionada no es cuadrada.");
                }
            }

            return (true, "");
        }

        // complejidad en tiempo: O(n^2)
        // complejidad en espacio: O(n^2)
        public Matrix Rotate()
        {
            int n = Values.Count;

            List<List<int>> rotatedValues = new List<List<int>>(n);

            for (int col = n - 1; col >= 0; col--)
            {
                List<int> newRow = new List<int>();

                for (int row = 0; row < n; row++)
                {
                    newRow.Add(Values[row][col]);
                }

                rotatedValues.Add(newRow);
            }

            Values = rotatedValues;

            return this;
        }

    }
}
