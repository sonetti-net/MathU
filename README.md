# MathU
Math Utilities: Stuff I've gone and learned at university.
Last updated: 15/11/2023

***

## structs
### Vector3
- Usage: Vector3 vector = new Vector3(x, y, z);
- Vector3.Magnitude()
- Vector3.Normalized()
- Vector3.ToString()
- Operations: *, +, /, -

### Matrices
- Usage: Matrix matrix1x3 = new Matrix(1, 3);
- Operations:
-   * ## nxn Dimensions
-   * *(Matrix*Matrix), (Matrix*Vector2), (Matrix*Scalar): returns Matrix of mxn
    * Magnitude(): Returns the magnitude or norm of a matrix.
    * Unit(): Divides each matrix value by it's norm.
    * Transpose(): Turns rows into colums.
    * Determinant(): Returns a floating point value of the input Matrix' determinant.
    * SubMatrix(int row, int col): Returns a matrix of dimensions: this->rows-1, this->cols-1, ignoring rows and colums specified in arguments.
    * Minors(): Returns a matrix of determinants obtained from SubMatrix.
    * Cofactor(): Multiplies each cell by positive or negative in a checkerbox pattern.
    * Inverse(): Returns the inverse of the Matrix.
 
    * ## 3x3 Dimensions
    * Project(Vector3 n, float scale): Returns a Matrix to Projects onto a plane scaled by input. 0 for orthographic projection.
    
- Features: Will throw exception when multiplication not supported.
***

## Misc Functions/Operations:
- Sqrt(x)
- Floor(x)
- Pow(x, power)


***
## Planned:
- Quaternions
- Euler rotations
- Matrix rotation
