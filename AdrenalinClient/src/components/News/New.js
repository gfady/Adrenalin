import React from 'react';
import styles from './new.module.css';

export default function New({ newItem }) {
  return (
    <div className={styles.newWrapper}>
      <div className={styles.date}>
        <label>{newItem.date}</label>
      </div>
      <img
        src={require('../../assets/img/' + newItem.img)}
        alt="new-image"
      ></img>
      <div className={styles.newText}>
        <h4>{newItem.title}</h4>
        <p>{newItem.text}</p>
      </div>
    </div>
  );
}
