export const encode = (stringToEncode) => {
  if (!stringToEncode) {
    return '';
  }

  const groupedCharacters = stringToEncode.match(/(\D)\1*/g);
  return groupedCharacters
    .map((character) => {
      if (character.length === 1) return character;

      return `${character.length}${character[0]}`;
    })
    .join('');
};

export const decode = (stringToDecode) => {
  if (!stringToDecode) {
    return '';
  }

  return stringToDecode
    .match(/\d*\D/g)
    .map((item) => {
      if (item.length === 1) {
        return item;
      }

      const letter = item.charAt(item.length - 1);
      const number = item.slice(0, item.length - 1);
      return letter.repeat(Number(number));
    })
    .join('');
};
