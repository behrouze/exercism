export class Triangle {
  constructor(...sides) {
    this.sides = sides;
  }

  sum(array) {
    return array.reduce((acc, x) => acc + x, 0);
  }

  spliceSides(index) {
    return this.sides.filter((x, i) => i !== index);
  }

  get numberOfDistinctSides() {
    return [...new Set(this.sides)].length;
  }

  get isTriangleInequalityOk() {
    let sidesVerified = this.sides.filter((side, idx) => {
      const otherSides = this.spliceSides(idx);
      return this.sum(otherSides) >= side;
    });
    return sidesVerified.length === 3;
  }

  get isEquilateral() {
    if (!this.sides[0]) return false;
    return this.numberOfDistinctSides === 1;
  }

  get isIsosceles() {
    if (!this.isTriangleInequalityOk) return false;
    return this.numberOfDistinctSides <= 2;
  }

  get isScalene() {
    if (!this.isTriangleInequalityOk) return false;
    return this.numberOfDistinctSides === 3;
  }
}
