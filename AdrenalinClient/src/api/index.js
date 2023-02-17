// export const BASE_URL = process.env.REACT_APP_API_URL;  https://localhost:7255
export const BASE_URL = 'https://localhost:7255';

export const ENDPOINTS = {
  new: 'new',
  promotion: 'promotion',
  user: 'user',
  visit: 'visit',
  club: 'club',
};

export const createAPIEndpoint = (endpoint, method) => {
  let url =
    method != ''
      ? BASE_URL + '/api/' + endpoint + '/' + method
      : BASE_URL + '/api/' + endpoint + '/';
  return url;
};
