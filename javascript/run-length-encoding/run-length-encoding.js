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
  if (stringToDecode.length === 0) { return ''; }

  const arrayOfEndoded = stringToDecode.match(/[0-9]*[a-zA-Z ]/g);
  const interm = arrayOfEndoded.map((item) => {
    if (item.length === 1) { return item; }

    const letter = item.charAt(item.length - 1);
    const number = item.slice(0, item.length - 1);
    return letter.repeat(Number(number));
  });

  return interm.join('');
};
