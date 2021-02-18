export const decodedValue = (arrayOfColor) => {
  const correspondigNumber = arrayOfColor
    .slice(0, 2)
    .map((color) => COLORS.indexOf(color))
    .join('');

  return Number(correspondigNumber);
};

const COLORS = [
  'black',
  'brown',
  'red',
  'orange',
  'yellow',
  'green',
  'blue',
  'violet',
  'grey',
  'white',
];
