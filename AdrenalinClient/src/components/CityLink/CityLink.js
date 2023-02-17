import React from 'react';
import styles from './cityLink.module.css';
import { Context } from '../../Context';
import { useContext } from 'react';

export default function CityLink({ city }) {
  const [context, setContext] = useContext(Context);

  const clickHandler = () => {
    setContext(city);
  };

  return (
    <div className={styles.cityLinkWrapper} onClick={clickHandler}>
      <hr />
      <p>
        Адреналин в <br></br>
        {city}
      </p>
    </div>
  );
}
