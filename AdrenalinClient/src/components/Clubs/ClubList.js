import React, { useState, useEffect, useContext } from 'react';
import styles from './clubs.module.css';
import Club from './Club';
import { createAPIEndpoint, ENDPOINTS } from '../../api/index.js';
import axios from 'axios';
import { Context } from '../../Context';
import NothingWasFound from '../NothingWasFound/NothingWasFound';
// import { clubs } from '../../data/consts';

const defineParameter = (contextValue) => {
  switch (contextValue) {
    case 'Минске':
      return 'Минск';
    case 'Пинске':
      return 'Пинск';
    case 'Гомеле':
      return 'Гомель';
    case 'Лунинце':
      return 'Лунинец';
    case 'Орше':
      return 'Орша';
    default:
      return 'none';
  }
};

export default function ClubList() {
  const [context] = useContext(Context);
  const [clubs, setClubs] = useState([]);

  useEffect(() => {
    let parameter = defineParameter(context);
    const path = createAPIEndpoint(
      ENDPOINTS.club,
      `getallclubsbycity/${parameter}`
    );

    axios.get(path).then((response) => {
      setClubs(response.data);
      response.data ? console.log(response.data) : console.log(response);
    });
  }, [context]);

  return (
    <div id="clibsList" className={styles.wrapper}>
      <h1>Выбери свой клуб</h1>
      <div className={styles.clubsWrapper}>
        {Array.isArray(clubs) ? (
          clubs.map((club) => {
            return <Club key={club.id} clubItem={club}></Club>;
          })
        ) : (
          <NothingWasFound></NothingWasFound>
        )}
      </div>
    </div>
  );
}
