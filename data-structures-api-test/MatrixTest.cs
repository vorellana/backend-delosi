using Xunit;
using data_structures_api.DTOs;
using System.Collections.Generic;

namespace data_structures_api.Tests
{
    public class MatrixTest
    {
        [Fact]
        public void Rotate_ShouldReturnRotatedMatrix_WhenMatrixIsValid()
        {
            var originalMatrix = new List<List<int>> {
                new List<int> { 1, 2, 3 },
                new List<int> { 4, 5, 6 },
                new List<int> { 7, 8, 9 }
            };

            var expectedMatrix = new List<List<int>> {
                new List<int> { 3, 6, 9 },
                new List<int> { 2, 5, 8 },
                new List<int> { 1, 4, 7 }
            };

            var matrix = new Matrix(originalMatrix);

            var rotatedMatrix = matrix.Rotate();

            // Assert
            Assert.Equal(expectedMatrix, rotatedMatrix.Values);
        }

        // Se pueden agregar más casos de prueba para el método IsValid y Rotate...
    }
}
