const formatResult = (result, acc) => {
  const letter = acc.slice(0, 1);
  return acc.length === 1 ?
      `${letter}`
      :
      `${acc.length}${letter}`;
};

export const encode = (stringToEncode) => {
  let result = '';

  stringToEncode.split('').reduce((acc, curr, index) => {
    if (acc.length === 0 || acc.includes(curr)) {
      acc.push(curr);
    } else {
      result += formatResult(result, acc);
      acc = [curr];
    }

    // last letter
    if (stringToEncode.length === index + 1) {
      result += formatResult(result, acc);
    }

    return acc;
  }, []);

  return result;
};

export const decode = (stringToDecode) => {
  let number = '';
  let finalResult = '';

  for (const character of stringToDecode) {
    if (typeof (character) === 'number') { number += character.toString(); } else {
      const result = number === '' ? character : character.repeat(number);
      number = '';
      finalResult += result;
    }
  }

  return finalResult;
};
