function Transcriptor() {
  const transcript = {
    G: 'C',
    C: 'G',
    T: 'A',
    A: 'U',
  };

  const translateSingleNucleotide = (nucleotide) => {
    const res = transcript[nucleotide];
    if (res !== undefined) {
      return res;
    }
    throw new Error('Invalid input DNA.');
  };

  this.toRna = (nucleotides) =>
    nucleotides
      .split('')
      .map((letter) => translateSingleNucleotide(letter))
      .join('');
}

export default Transcriptor;
