export const transform = (scoring) => {
  const oldScores = Object.keys(scoring);
  let newScores = {};

  oldScores.map((score) => {
    const letters = scoring[score];
    letters.map((letter) => (newScores = { ...newScores, [letter.toLowerCase()]: Number(score) }));
  });

  return newScores;
};
