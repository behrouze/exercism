export const transform = (scoring) => {
  return Object.keys(scoring).reduce((acc, score) => {
    return scoring[score].reduce(
      (acc2, letter) => (acc = { ...acc, [letter.toLowerCase()]: Number(score) }),
      {}
    );
  }, {});
};
