use std::ops::{ Index, Mul };
use ::vectors::{ AffineVector, Vector };

pub enum Cell {
    I1, J1, K1, W1,
    I2, J2, K2, W2,
    I3, J3, K3, W3,
    I4, J4, K4, W4,
    Row(u8),
    Column(u8),
}

impl Cell {
    pub fn to_column(&self) -> Cell {
        match self {
            &Cell::I1 => Cell::Column(0), &Cell::J1 => Cell::Column(4), &Cell::K1 => Cell::Column(8),  &Cell::W1 => Cell::Column(12),
            &Cell::I2 => Cell::Column(1), &Cell::J2 => Cell::Column(5), &Cell::K2 => Cell::Column(9),  &Cell::W2 => Cell::Column(13),
            &Cell::I3 => Cell::Column(2), &Cell::J3 => Cell::Column(6), &Cell::K3 => Cell::Column(10), &Cell::W3 => Cell::Column(14),
            &Cell::I4 => Cell::Column(3), &Cell::J4 => Cell::Column(7), &Cell::K4 => Cell::Column(14), &Cell::W4 => Cell::Column(15),
            &Cell::Column(i) => Cell::Column(i),
            &Cell::Row(i) => Cell::Column((i * 4 % 16) + (i / 4))
        }
    }
}

#[derive(Debug)]
#[derive(PartialEq)]
pub struct AffineMatrix {
    i1 : f64, j1 : f64, k1 : f64, w1 : f64,
    i2 : f64, j2 : f64, k2 : f64, w2 : f64,
    i3 : f64, j3 : f64, k3 : f64, w3 : f64,
    i4 : f64, j4 : f64, k4 : f64, w4 : f64
}

impl AffineMatrix {

    // column vector (1, 2, 3, 4)
    pub fn cvec(&self, column : u8) -> AffineVector {
        let start = (column - 1) * 4;
        AffineVector::new(
            self[Cell::Column(start + 0)],
            self[Cell::Column(start + 1)],
            self[Cell::Column(start + 2)],
            self[Cell::Column(start + 3)])
    }

    // row vector (1, 2, 3, 4)
    pub fn rvec(&self, row : u8) -> AffineVector {
        let start = (row - 1) * 4;
        AffineVector::new(
            self[Cell::Row(start + 0)],
            self[Cell::Row(start + 1)],
            self[Cell::Row(start + 2)],
            self[Cell::Row(start + 3)])
    }

    pub fn multiply(&self, m : AffineMatrix) -> AffineMatrix {
        let c1 = self.cvec(1);
        let c2 = self.cvec(2);
        let c3 = self.cvec(3);
        let c4 = self.cvec(4);
        let r1 = m.rvec(1);
        let r2 = m.rvec(2);
        let r3 = m.rvec(3);
        let r4 = m.rvec(4);

        AffineMatrix {
            i1: c1.dot(r1), j1: c2.dot(r1), k1: c3.dot(r1), w1: c4.dot(r1),
            i2: c1.dot(r2), j2: c2.dot(r2), k2: c3.dot(r2), w2: c4.dot(r2),
            i3: c1.dot(r3), j3: c2.dot(r3), k3: c3.dot(r3), w3: c4.dot(r3),
            i4: c1.dot(r4), j4: c2.dot(r4), k4: c3.dot(r4), w4: c4.dot(r4),
        }
    }

    pub fn apply_affine(&self, a : AffineVector) -> AffineVector {
        AffineVector::new(self.rvec(1).dot(a),  self.rvec(2).dot(a), self.rvec(3).dot(a), self.rvec(4).dot(a))
    }

    pub fn apply_vec3(&self, v : Vector) -> Vector {
        let a = self.apply_affine(AffineVector::new(v.x(), v.y(), v.z(), 1.));
        Vector::new(a.x(), a.y(), a.z())
    }

    pub fn inverse(&self) -> AffineMatrix {
        let m = self;
        let s0 = m.i1 * m.j2 - m.i2 * m.j1;
        let s1 = m.i1 * m.k2 - m.i2 * m.k1;
        let s2 = m.i1 * m.w2 - m.i2 * m.w1;
        let s3 = m.j1 * m.k2 - m.j2 * m.k1;
        let s4 = m.j1 * m.w2 - m.j2 * m.w1;
        let s5 = m.k1 * m.w2 - m.k2 * m.w1;
        let c5 = m.k3 * m.w4 - m.k4 * m.w3;
        let c4 = m.j3 * m.w4 - m.j4 * m.w3;
        let c3 = m.j3 * m.k4 - m.j4 * m.k3;
        let c2 = m.i3 * m.w4 - m.i4 * m.w3;
        let c1 = m.i3 * m.k4 - m.i4 * m.k3;
        let c0 = m.i3 * m.j4 - m.i4 * m.j3;
        let d = 1.0 / (s0 * c5 - s1 * c4 + s2 * c3 + s3 * c2 - s4 * c1 + s5 * c0);

        AffineMatrix {
            i1: ( m.j2 * c5 - m.k2 * c4 + m.w2 * c3) * d,
            j1: (-m.j1 * c5 + m.k1 * c4 - m.w1 * c3) * d,
            k1: ( m.j4 * s5 - m.k4 * s4 + m.w4 * s3) * d,
            w1: (-m.j3 * s5 + m.k3 * s4 - m.w3 * s3) * d,
            i2: (-m.i2 * c5 + m.k2 * c2 - m.w2 * c1) * d,
            j2: ( m.i1 * c5 - m.k1 * c2 + m.w1 * c1) * d,
            k2: (-m.i4 * s5 + m.k4 * s2 - m.w4 * s1) * d,
            w2: ( m.i3 * s5 - m.k3 * s2 + m.w3 * s1) * d,
            i3: ( m.i2 * c4 - m.j2 * c2 + m.w2 * c0) * d,
            j3: (-m.i1 * c4 + m.j1 * c2 - m.w1 * c0) * d,
            k3: ( m.i4 * s4 - m.j4 * s2 + m.w4 * s0) * d,
            w3: (-m.i3 * s4 + m.j3 * s2 - m.w3 * s0) * d,
            i4: (-m.i2 * c3 + m.j2 * c1 - m.k2 * c0) * d,
            j4: ( m.i1 * c3 - m.j1 * c1 + m.k1 * c0) * d,
            k4: (-m.i4 * s3 + m.j4 * s1 - m.k4 * s0) * d,
            w4: ( m.i3 * s3 - m.j3 * s1 + m.k3 * s0) * d,
        }
    }

    pub fn from_row_major(array : Vec<f64>) -> AffineMatrix {
        AffineMatrix {
            i1: array[0], j1: array[1], k1: array[2], w1: array[3],
            i2: array[4], j2: array[5], k2: array[6], w2: array[7],
            i3: array[8], j3: array[9], k3: array[10],w3: array[11],
            i4: array[12],j4: array[13],k4: array[14],w4: array[15],
        }
    }

    pub fn from_column_major(array : Vec<f64>) -> AffineMatrix {
        AffineMatrix {
            i1: array[0], j1: array[4], k1: array[8], w1: array[12],
            i2: array[1], j2: array[5], k2: array[9], w2: array[13],
            i3: array[2], j3: array[6], k3: array[10],w3: array[14],
            i4: array[3], j4: array[7], k4: array[11],w4: array[15],
        }
    }

    pub fn Zero() -> AffineMatrix {
        AffineMatrix::from_row_major(vec![0.0;16])
    }

    pub fn Identity() -> AffineMatrix {
        AffineMatrix {
            i1: 1., j1: 0., k1: 0., w1: 0.,
            i2: 0., j2: 1., k2: 0., w2: 0.,
            i3: 0., j3: 0., k3: 1., w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn Translation(x : f64, y : f64, z : f64) -> AffineMatrix {
        AffineMatrix {
                i1: 1., j1: 0., k1: 0., w1: x ,
                i2: 0., j2: 1., k2: 0., w2: y ,
                i3: 0., j3: 0., k3: 1., w3: z ,
                i4: 0., j4: 0., k4: 0., w4: 1.,
            }
    }

    pub fn RotationX(theta : f64) -> AffineMatrix {
        let c = theta.cos();
        let s = theta.sin();
        AffineMatrix {
            i1: 1., j1: 0., k1: 0., w1: 0.,
            i2: 0., j2: c , k2: -s, w2: 0.,
            i3: 0., j3: s , k3: c , w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn RotationY(theta : f64) -> AffineMatrix {
        let c = theta.cos();
        let s = theta.sin();
        AffineMatrix {
            i1: c , j1: 0., k1: s , w1: 0.,
            i2: 0., j2: 1., k2: 0., w2: 0.,
            i3: -s, j3: 0., k3: c , w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn RotationZ(theta : f64) -> AffineMatrix {
        let c = theta.cos();
        let s = theta.sin();
        AffineMatrix {
            i1: c , j1: -s, k1: 0., w1: 0.,
            i2: s , j2: c , k2: 0., w2: 0.,
            i3: 0., j3: 0., k3: 1., w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn Scale(x : f64, y : f64, z : f64) -> AffineMatrix {
        AffineMatrix {
            i1: x , j1: 0., k1: 0., w1: 0.,
            i2: 0., j2: y , k2: 0., w2: 0.,
            i3: 0., j3: 0., k3: z , w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn UniformScale(s : f64) -> AffineMatrix {
        AffineMatrix {
            i1: s , j1: 0., k1: 0., w1: 0.,
            i2: 0., j2: s , k2: 0., w2: 0.,
            i3: 0., j3: 0., k3: s , w3: 0.,
            i4: 0., j4: 0., k4: 0., w4: 1.,
        }
    }

    pub fn transpose(&self) -> AffineMatrix {
        AffineMatrix {
            i1: self.i1, j1: self.i2, k1: self.i3, w1: self.i4,
            i2: self.j1, j2: self.j2, k2: self.j3, w2: self.j4,
            i3: self.k1, j3: self.k2, k3: self.k3, w3: self.k4,
            i4: self.w1, j4: self.w2, k4: self.w3, w4: self.w4
        }
    }

    pub fn as_row_major_vec(&self) -> Vec<f64> {
        vec![
            self.i1, self.j1, self.k1, self.w1,
            self.i2, self.j2, self.k2, self.w2,
            self.i3, self.j3, self.k3, self.w3,
            self.i4, self.j4, self.k4, self.w4
        ]
    }
}

impl Index<Cell> for AffineMatrix {
    type Output = f64;
    fn index(&self, c : Cell) -> &f64 {
        match c {
            Cell::I1 => &self.i1, Cell::I2 => &self.i2, Cell::I3 => &self.i3, Cell::I4 => &self.i4,
            Cell::J1 => &self.j1, Cell::J2 => &self.j2, Cell::J3 => &self.j3, Cell::J4 => &self.j4,
            Cell::K1 => &self.k1, Cell::K2 => &self.k2, Cell::K3 => &self.k3, Cell::K4 => &self.k4,
            Cell::W1 => &self.w1, Cell::W2 => &self.w2, Cell::W3 => &self.w3, Cell::W4 => &self.w4,
            Cell::Column(0) => &self.i1, Cell::Column(4) => &self.j1, Cell::Column(8) => &self.k1, Cell::Column(12) => &self.w1,
            Cell::Column(1) => &self.i2, Cell::Column(5) => &self.j2, Cell::Column(9) => &self.k2, Cell::Column(13) => &self.w2,
            Cell::Column(2) => &self.i3, Cell::Column(6) => &self.j3, Cell::Column(10) =>&self.k3, Cell::Column(14) => &self.w3,
            Cell::Column(3) => &self.i4, Cell::Column(7) => &self.j4, Cell::Column(11) =>&self.k4, Cell::Column(15) => &self.w4,
            Cell::Column(_) => panic!("Matrix Index out of bounds"),
            Cell::Row(0) => &self.i1, Cell::Row(1) => &self.j1, Cell::Row(2) => &self.k1, Cell::Row(3) => &self.w1,
            Cell::Row(4) => &self.i2, Cell::Row(5) => &self.j2, Cell::Row(6) => &self.k2, Cell::Row(7) => &self.w2,
            Cell::Row(8) => &self.i3, Cell::Row(9) => &self.j3, Cell::Row(10) =>&self.k3, Cell::Row(11) =>&self.w3,
            Cell::Row(12) =>&self.i4, Cell::Row(13) =>&self.j4, Cell::Row(14) =>&self.k4, Cell::Row(15) =>&self.w4,
            Cell::Row(_) => panic!("Matrix Index out of bounds"),
        }
    }
}

impl Index<i32> for AffineMatrix {
    type Output = f64;
    fn index(&self, c : i32) -> &f64 {
        match c {
            0 => &self.i1, 4 => &self.i2, 8 => &self.i3, 12=> &self.i4,
            1 => &self.j1, 5 => &self.j2, 9 => &self.j3, 13=> &self.j4,
            2 => &self.k1, 6 => &self.k2, 10=> &self.k3, 14=> &self.k4,
            3 => &self.w1, 7 => &self.w2, 11=> &self.w3, 15=> &self.w4,
            _  => panic!("Matrix Index out of bounds")
        }
    }
}

impl Mul for AffineMatrix {
    type Output = AffineMatrix;
    fn mul(self, m : AffineMatrix)  -> AffineMatrix {
        self.multiply(m)
    }
}

impl Mul<Vector> for AffineMatrix {
    type Output = Vector;
    fn mul(self, v : Vector) -> Vector {
        self.apply_vec3(v)
    }
}

impl Mul<AffineVector> for AffineMatrix {
    type Output = AffineVector;
    fn mul(self, v : AffineVector) -> AffineVector {
        self.apply_affine(v)
    }
}