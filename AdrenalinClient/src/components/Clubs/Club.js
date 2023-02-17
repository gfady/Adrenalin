import React from 'react';
import styles from './clubs.module.css';

export default function Club({ clubItem }) {
  return (
    <div className={styles.clubItemWrapper}>
      <img
        src={require('../../assets/img/' + clubItem.image)}
        alt="new-image"
      ></img>
      <div className={styles.textBlock}>
        <p>{clubItem.city}</p>
        <p>{clubItem.adress}</p>
      </div>
    </div>
  );
}
