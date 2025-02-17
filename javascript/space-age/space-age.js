const yearInSeconds = 60 * 60 * 24 * 365.25;
const orbitalPeriod = {
  mercury: 0.2408467,
  venus: 0.61519726,
  earth: 1.0,
  mars: 1.8808158,
  jupiter: 11.862615,
  saturn: 29.447498,
  uranus: 84.016846,
  neptune: 164.79132,
};

export const age = (planet, ageInSeconds) => {
  const spaceAge = ageInSeconds / (yearInSeconds * orbitalPeriod[planet]);
  return Number.parseFloat(spaceAge.toFixed(2));
};
