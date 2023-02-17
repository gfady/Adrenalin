import React, { useState, useEffect } from 'react';
import New from './New';
import { ENDPOINTS, createAPIEndpoint } from '../../api';
import axios from 'axios';
// import { news } from '../../data/consts';

export default function NewsList() {
  const [news, setNews] = useState([]);

  useEffect(() => {
    const path = createAPIEndpoint(ENDPOINTS.new, 'getallnews');
    axios.get(path).then((response) => {
      setNews(response.data);
      console.log(response.data);
    });
  }, []);

  return (
    <div>
      {news.map((newItem) => (
        <New key={newItem.id} newItem={newItem}></New>
      ))}
    </div>
  );
}
