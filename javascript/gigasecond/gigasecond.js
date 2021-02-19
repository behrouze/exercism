const GIGASECOND_IN_MS = Math.pow(10, 12);
export const gigasecond = (moment) => new Date(moment.getTime() + GIGASECOND_IN_MS);
